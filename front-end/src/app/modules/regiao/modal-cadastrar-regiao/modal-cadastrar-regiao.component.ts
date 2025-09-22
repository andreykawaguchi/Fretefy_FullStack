import { Component } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { FormBuilder, FormGroup, Validators, FormArray, FormControl, AbstractControl, ValidatorFn } from '@angular/forms';
import { RegiaoDto } from 'src/app/Dtos/RegiaoDto';
import { CreateRegiaoInput, UpdateRegiaoInput } from 'src/app/Dtos/RegiaoInputDto';
import { CidadeDto } from 'src/app/Dtos/CidadeDto';
import { CidadeService } from 'src/app/services/cidade.service';
import { Inject } from '@angular/core';
import { REGIAO_REPOSITORY } from '../domain/tokens';
import { IRegiaoRepository } from '../domain/iregiao.repository';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-modal-cadastrar-regiao',
  templateUrl: './modal-cadastrar-regiao.component.html',
  styleUrls: ['./modal-cadastrar-regiao.component.scss']
})
export class ModalCadastrarRegiaoComponent {
  form: FormGroup;
  cidades: CidadeDto[] = [];
  isSaving = false;

  readonly maxCidades = 2;

  constructor(
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<ModalCadastrarRegiaoComponent>,
    private cidadeService: CidadeService,
    @Inject(REGIAO_REPOSITORY) private regiaoRepository: IRegiaoRepository,
    private snackBar: MatSnackBar,
    @Inject(MAT_DIALOG_DATA) public data: { regiao?: RegiaoDto, readOnly?: boolean }
  ) {
    this.form = this.fb.group({
      id: [this.data && this.data.regiao ? this.data.regiao.id : null],
      nome: [this.data && this.data.regiao ? this.data.regiao.nome : '', [Validators.required, Validators.maxLength(100)]],
      // require at least 1 cidade
      cidadesSelecionadas: this.fb.array([] as FormControl[], [this.minSelectedCities(1)])
    });

  }

  ngOnInit() {
    this.getCidades();
    if (this.data && this.data.readOnly) {
      this.form.disable({ emitEvent: false });
    }
  }

  getCidades() {
    this.cidadeService.list().subscribe(cidades => {
      this.cidades = cidades;

      if (this.data && this.data.regiao && this.data.regiao.cidades) {
        const arr = this.form.get('cidadesSelecionadas') as FormArray;
        arr.clear();
        this.data.regiao.cidades.forEach(c => {
          arr.push(new FormControl(c.id || ''));
        });

        arr.updateValueAndValidity();
      }
    });
  }

  minSelectedCities(min: number): ValidatorFn {
    return (control: AbstractControl) => {
      if (!(control instanceof FormArray)) return null;
      const arr = control.value as Array<any>;
      const count = (arr || []).filter(v => !!v).length;
      return count >= min ? null : { minCidades: { required: min, actual: count } };
    };
  }

  isCidadeSelected(cidadeId: string | number): boolean {
    if (!cidadeId) return false;
    const arr = (this.form.get('cidadesSelecionadas') as FormArray).value as Array<string | number>;
    return arr.filter(v => !!v).map(v => String(v)).includes(String(cidadeId));
  }

  availableCidades(index: number): CidadeDto[] {
    const arr = (this.form.get('cidadesSelecionadas') as FormArray).value as Array<string | number>;
    const selectedExceptCurrent = arr
      .map(v => v ? String(v) : '')
      .map((v, i) => i === index ? '' : v)
      .filter(v => !!v);
    return this.cidades.filter(c => !selectedExceptCurrent.includes(String(c.id)));
  }

  save() {
    if (this.form.invalid) {
      this.form.markAllAsTouched();

      const arr = this.form.get('cidadesSelecionadas') as FormArray;
      if (arr) {
        try { (arr as any).markAllAsTouched(); } catch (e) { arr.controls.forEach(c => c.markAsTouched()); }
      }
      return;
    }

    const selectedArray = (this.form.get('cidadesSelecionadas') as FormArray).value as string[];
    const selected = selectedArray.filter(s => !!s).slice(0, this.maxCidades);

    const payload: CreateRegiaoInput = {
      nome: this.form.value.nome,
      regiaoCidades: selected.map(c => ({ cidadeId: String(c) }))
    };
    this.isSaving = true;

    if (this.data && this.data.regiao && this.data.regiao.id) {
      // update
      const id = (this.data.regiao.id as any);
      const updatePayload: UpdateRegiaoInput = Object.assign({ id: String(id) }, payload);
      this.regiaoRepository.update(id, updatePayload).subscribe({
        next: () => {
          this.isSaving = false;
          this.snackBar.open('Região atualizada com sucesso', 'Fechar', { duration: 3000 });
          this.dialogRef.close(updatePayload);
        },
        error: (err) => {
          console.error(err);
          this.isSaving = false;
          this.snackBar.open((err && err.error.message) ? err.error.message : 'Erro ao atualizar região', 'Fechar', { duration: 4000 });
        }
      });
    } else {
      // create
      this.regiaoRepository.create(payload).subscribe({
        next: (created) => {
          this.isSaving = false;
          this.snackBar.open('Região criada com sucesso', 'Fechar', { duration: 3000 });
          this.dialogRef.close(created || payload);
        },
        error: (err) => {
          console.error(err);
          this.isSaving = false;
          this.snackBar.open((err && err.error.message) ? err.error.message : 'Erro ao criar região', 'Fechar', { duration: 4000 });
        }
      });
    }
  }

  cancel() {
    this.dialogRef.close(null);
  }

  removeCidade(index: number) {
    const arr = this.form.get('cidadesSelecionadas') as FormArray;
    arr.removeAt(index);
    arr.updateValueAndValidity();
  }

  addCidade() {
    const arr = this.form.get('cidadesSelecionadas') as FormArray;
    if (arr.length >= 2) return;
    arr.push(new FormControl(''));
    arr.updateValueAndValidity();
  }

  cidadesControls() {
    return (this.form.get('cidadesSelecionadas') as FormArray).controls as FormControl[];
  }
}

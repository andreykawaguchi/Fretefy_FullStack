import { Component, OnInit, ViewChild } from '@angular/core';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { RegiaoDto } from 'src/app/Dtos/RegiaoDto';
import { CidadeDto } from 'src/app/Dtos/CidadeDto';
import { RegiaoService } from 'src/app/services/regiao.service';
import { PagedResult } from 'src/app/Dtos/paged-result.model';
import { Pagination } from 'src/app/Dtos/pagination.model';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort, Sort } from '@angular/material/sort';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ModalCadastrarRegiaoComponent } from './modal-cadastrar-regiao/modal-cadastrar-regiao.component';
import { HttpResponse } from '@angular/common/http';

@Component({
  selector: 'app-regiao',
  templateUrl: './regiao.component.html',
  styleUrls: ['./regiao.component.scss'],
  animations: [
    trigger('detailExpand', [
      state('collapsed', style({height: '0px', minHeight: '0'})),
      state('expanded', style({height: '*'})),
      transition('expanded <=> collapsed', animate('225ms cubic-bezier(0.4, 0.0, 0.2, 1)')),
    ]),
  ]
})
export class RegiaoComponent implements OnInit {
  regioes: RegiaoDto[] = [];
  pagination: Pagination | null = null;

  @ViewChild(MatPaginator) paginator: MatPaginator | null = null;
  @ViewChild(MatSort) sort: MatSort | null = null;
  pageIndex = 0;
  pageSize = 10;
  totalItems = 0;
  isLoading = false;
  error: string | null = null;

  displayedColumns: string[] = ['nome', 'cidades', 'ativo',  'actions'];
  dataSource: RegiaoDto[] = [];
  expandedElement: RegiaoDto | null = null;

  constructor(
    private regiaoService: RegiaoService
    ,private dialog: MatDialog
    ,private snackBar: MatSnackBar
  ) { }

  ngOnInit() {
    this.getRegioes();
  }

  onToggleAtivo(regiao: RegiaoDto, novoValor: boolean) {
    if (!regiao || !regiao.id) return;

    const id = String(regiao.id);

    const original = regiao.ativo;
    regiao.ativo = novoValor;

    const obs = novoValor ? this.regiaoService.ativar(id) : this.regiaoService.desativar(id);

    obs.subscribe({
      next: () => {
        this.snackBar.open('Status atualizado', 'Fechar', { duration: 2000 });
      },
      error: (err) => {
        console.error(err);

        regiao.ativo = original;
        this.snackBar.open((err && err.error && err.error.message) ? err.error.message : 'Erro ao atualizar status', 'Fechar', { duration: 4000 });
      }
    });
  }

  // sortBy: 'nome' | 'cidades' | undefined
  sortBy: string | null = 'nome';
  // sortDirection: 'asc' | 'desc' | undefined
  sortDirection: string | null = 'asc';

  getRegioes(page: number = 1, pageSize: number = this.pageSize) {
    this.isLoading = true;
    this.error = null;
    this.regiaoService.paged(page, pageSize, this.sortBy, this.sortDirection).subscribe({
      next: (result: PagedResult<RegiaoDto>) => {
        this.regioes = (result && result.items) ? result.items : [];
        this.pagination = result && result.pagination ? result.pagination : null;
        this.dataSource = this.regioes;
        if (this.pagination) {

          this.pageIndex = (this.pagination.page && this.pagination.page > 0) ? this.pagination.page - 1 : 0;
          this.pageSize = this.pagination.pageSize || this.pageSize;
          this.totalItems = this.pagination.total || 0;
        }
        this.isLoading = false;
      },
      error: (err) => {
        console.error(err);
        this.error = (err && err.message) ? err.message : 'Erro ao carregar regiões.';
        this.isLoading = false;
      }
    });
  }

  onSortChange(sortState: Sort) {
    if (!sortState) return;
    this.sortBy = sortState.active || null;
    // Angular MatSort uses 'asc' | 'desc' | ''
    this.sortDirection = sortState.direction && sortState.direction.length > 0 ? sortState.direction : null;
    // reload first page with new sort
    this.getRegioes(1, this.pageSize);
  }

  onPageChange(event: PageEvent) {
    const page = event.pageIndex + 1;
    const pageSize = event.pageSize;
    this.getRegioes(page, pageSize);
  }

  openCreate() {
    const ref = this.dialog.open(ModalCadastrarRegiaoComponent, { width: '420px', data: {} });
    ref.afterClosed().subscribe(result => {
      if (result) {
        this.snackBar.open('Operação concluída', 'Fechar', { duration: 2000 });
        this.getRegioes(1, this.pageSize);
      }
    });
  }

  onView(regiao: RegiaoDto) {
    this.dialog.open(ModalCadastrarRegiaoComponent, { width: '420px', data: { regiao, readOnly: true }, disableClose: false });
  }

  onEdit(regiao: RegiaoDto) {
    const ref = this.dialog.open(ModalCadastrarRegiaoComponent, { width: '420px', data: { regiao } });
    ref.afterClosed().subscribe(result => {
      if (result) {
        this.snackBar.open('Operação concluída', 'Fechar', { duration: 2000 });
        this.getRegioes(1, this.pageSize);
      }
    });
  }

  isExpansion = (index: number, row: RegiaoDto) => {
    return row === this.expandedElement;
  }

  getCidadesNomes(regiao: RegiaoDto): string {
    if (!regiao || !regiao.cidades || regiao.cidades.length === 0) return '-';
    return regiao.cidades.map((c: CidadeDto) => c.nome).filter(n => !!n).join(', ');
  }


  private parseFilename(contentDisposition: string | null): string {
    if (!contentDisposition) return 'regioes.xlsx';
    const filenameMatch = /filename\*=UTF-8''([^;\n]+)/i.exec(contentDisposition) || /filename="?([^";]+)"?/i.exec(contentDisposition);
    if (filenameMatch && filenameMatch.length > 1) {
      try {
        // decode RFC5987 encoded filename* if present
        const raw = filenameMatch[1];
        return decodeURIComponent(raw);
      } catch (e) {
        return filenameMatch[1];
      }
    }
    return 'regioes.xlsx';
  }

  export() {
    this.isLoading = true;
    this.regiaoService.export().subscribe({
      next: (res: HttpResponse<Blob>) => {
        try {
          const contentDisposition = res && (res as any).headers ? (res as any).headers.get('content-disposition') : null;
          const filename = this.parseFilename(contentDisposition);

          const blob = res && res.body ? res.body as Blob : null;
          if (!blob) {
            this.snackBar.open('Arquivo vazio recebido do servidor.', 'Fechar', { duration: 4000 });
            return;
          }

          const url = window.URL.createObjectURL(blob);
          const a = document.createElement('a');
          a.href = url;
          a.download = filename || 'regioes.xlsx';
          document.body.appendChild(a);
          a.click();
          document.body.removeChild(a);
          window.URL.revokeObjectURL(url);

          this.snackBar.open('Download iniciado', 'Fechar', { duration: 2000 });
        } catch (err) {
          console.error(err);
          this.snackBar.open('Erro ao processar o arquivo para download.', 'Fechar', { duration: 4000 });
        } finally {
          this.isLoading = false;
        }
      },
      error: (err) => {
        console.error(err);
        this.snackBar.open((err && err.error && err.error.message) ? err.error.message : 'Erro ao exportar regiões', 'Fechar', { duration: 4000 });
        this.isLoading = false;
      }
    });
  }

}

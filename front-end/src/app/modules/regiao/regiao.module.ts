import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegiaoComponent } from './regiao.component';
import { ModalCadastrarRegiaoComponent } from './modal-cadastrar-regiao/modal-cadastrar-regiao.component';
import { RegiaoRoutingModule } from './regiao.routing';
import { MaterialModule } from '../../shared/material.module';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    RegiaoRoutingModule,
    MaterialModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  declarations: [RegiaoComponent, ModalCadastrarRegiaoComponent],
  exports: [RegiaoComponent]
})
export class RegiaoModule { }

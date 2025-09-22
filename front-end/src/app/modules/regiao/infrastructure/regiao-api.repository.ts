import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { IRegiaoRepository } from '../domain/iregiao.repository';
import { Regiao } from '../domain/regiao.entity';
import { RegiaoService } from '../../../../app/services/regiao.service';
import { RegiaoDto } from '../../../../app/Dtos/RegiaoDto';
import { PagedResult } from 'src/app/Dtos/paged-result.model';
import { CreateRegiaoInput, UpdateRegiaoInput } from 'src/app/Dtos/RegiaoInputDto';
import { HttpResponse } from '@angular/common/http';

@Injectable({ providedIn: 'root' })
export class RegiaoApiRepository implements IRegiaoRepository {
  constructor(private regiaoService: RegiaoService) { }

  list(): Observable<RegiaoDto[]> {
    return this.regiaoService.list();
  }

  paged(page?: number, pageSize?: number, sortBy?: string | null, sortDirection?: string | null): Observable<PagedResult<RegiaoDto>> {
    return this.regiaoService.paged(page, pageSize, sortBy, sortDirection);
  }

  create(regiao: CreateRegiaoInput): Observable<RegiaoDto> {
    return this.regiaoService.create(regiao);
  }

  update(id: string, regiao: UpdateRegiaoInput): Observable<void> {
    return this.regiaoService.update(id, regiao);
  }

  delete(id: string): Observable<void> {
    return this.regiaoService.delete(id);
  }

  ativar(id: string): Observable<void> {
    return this.regiaoService.ativar(id);
  }

  desativar(id: string): Observable<void> {
    return this.regiaoService.desativar(id);
  }

  export(sortBy?: string | null, sortDirection?: string | null): Observable<HttpResponse<Blob>> {
    return this.regiaoService.export(sortBy, sortDirection);
  }

  private toEntity(dto: RegiaoDto): Regiao {
    return {
      id: dto.id,
      nome: dto.nome,
      cidades: dto.cidades ? dto.cidades.map(c => ({ id: (c as any).id, nome: (c as any).nome })) : [],
      ativo: dto.ativo
    } as Regiao;
  }
}

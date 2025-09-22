import { Observable } from 'rxjs';
import { RegiaoDto } from 'src/app/Dtos/RegiaoDto';
import { PagedResult } from 'src/app/Dtos/paged-result.model';
import { CreateRegiaoInput, UpdateRegiaoInput } from 'src/app/Dtos/RegiaoInputDto';
import { HttpResponse } from '@angular/common/http';

export interface IRegiaoRepository {
  list(): Observable<RegiaoDto[]>;
  paged(page?: number, pageSize?: number, sortBy?: string | null, sortDirection?: string | null): Observable<PagedResult<RegiaoDto>>;
  create(regiao: CreateRegiaoInput): Observable<RegiaoDto>;
  update(id: string, regiao: UpdateRegiaoInput): Observable<void>;
  delete(id: string): Observable<void>;
  ativar(id: string): Observable<void>;
  desativar(id: string): Observable<void>;
  export(sortBy?: string | null, sortDirection?: string | null): Observable<HttpResponse<Blob>>;
}

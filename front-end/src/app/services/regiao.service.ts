import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { RegiaoDto } from '../Dtos/RegiaoDto';
import { CreateRegiaoInput, UpdateRegiaoInput } from '../Dtos/RegiaoInputDto';
import { PagedResult } from '../Dtos/paged-result.model';
import { buildPaginationParams } from '../utils/http-params.util';
import { CidadeDto as Cidade } from '../Dtos/CidadeDto';


@Injectable({
  providedIn: 'root'
})
export class RegiaoService {

  private apiUrl = environment && (environment as any).apiUrl ? (environment as any).apiUrl : '/api';
  private base = `${this.apiUrl}/regiao`;

  private jsonOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  // GET /api/regiao - Listar regiões
  list(): Observable<RegiaoDto[]> {
    return this.http.get<RegiaoDto[]>(this.base);
  }

  paged(page?: number, pageSize?: number, sortBy?: string | null, sortDirection?: string | null): Observable<PagedResult<RegiaoDto>> {
    const params = buildPaginationParams(page, pageSize, sortBy, sortDirection);
    return this.http.get<PagedResult<RegiaoDto>>(`${this.base}/paged`, { params });
  }

  // POST /api/regiao - Criar região
  create(regiao: CreateRegiaoInput): Observable<RegiaoDto> {
    return this.http.post<RegiaoDto>(this.base, regiao, this.jsonOptions);
  }

  // PUT /api/regiao/{id} - Atualizar região
  update(id: string, regiao: UpdateRegiaoInput): Observable<void> {
    return this.http.put<void>(`${this.base}/${id}`, regiao, this.jsonOptions);
  }

  // DELETE /api/regiao/{id} - Excluir região
  delete(id: string): Observable<void> {
    return this.http.delete<void>(`${this.base}/${id}`);
  }

  // POST /api/regiao/{id}/ativar - Ativar região
  ativar(id: string): Observable<void> {
    return this.http.post<void>(`${this.base}/${id}/ativar`, null);
  }

  // POST /api/regiao/{id}/desativar - Desativar região
  desativar(id: string): Observable<void> {
    return this.http.post<void>(`${this.base}/${id}/desativar`, null);
  }

  export(sortBy?: string | null, sortDirection?: string | null): Observable<any> {
    const params = buildPaginationParams(undefined, undefined, sortBy, sortDirection);
    return this.http.get(`${this.base}/export`, { params, responseType: 'blob' as 'json', observe: 'response' as 'body' });
  }
}

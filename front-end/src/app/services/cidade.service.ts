import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { CidadeDto as Cidade } from '../Dtos/CidadeDto';


@Injectable({
  providedIn: 'root'
})
export class CidadeService {

  private apiUrl = environment && (environment as any).apiUrl ? (environment as any).apiUrl : '/api';
  private base = `${this.apiUrl}/cidade`;

  private jsonOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  list(): Observable<Cidade[]> {
    return this.http.get<Cidade[]>(this.base);
  }

}

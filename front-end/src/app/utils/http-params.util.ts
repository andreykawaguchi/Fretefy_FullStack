import { HttpParams } from '@angular/common/http';

export function buildPaginationParams(page?: number, pageSize?: number, sortBy?: string | null, sortDirection?: string | null): HttpParams {
  let params = new HttpParams();
  if (page !== undefined && page !== null) {
    params = params.set('page', String(page));
  }
  if (pageSize !== undefined && pageSize !== null) {
    params = params.set('pageSize', String(pageSize));
  }
  if (sortBy !== undefined && sortBy !== null && String(sortBy).trim() !== '') {
    params = params.set('sortBy', String(sortBy));
  }
  if (sortDirection !== undefined && sortDirection !== null && String(sortDirection).trim() !== '') {
    params = params.set('sortDirection', String(sortDirection));
  }
  return params;
}

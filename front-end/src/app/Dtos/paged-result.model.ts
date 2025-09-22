import { Pagination } from './pagination.model';

export interface PagedResult<T> {
  items: T[];
  pagination: Pagination;
}

import { RegiaoCidadeDto } from './RegiaoCidadeDto';

export interface CidadeDto {
  id: string;
  nome: string;
  uf?: string;
  regiaoCidade?: RegiaoCidadeDto[];
}

import { CidadeDto } from './CidadeDto';

// Front-end DTO aligned with backend DDD RegiaoDto
export interface RegiaoDto {
  id: string;
  nome: string;
  // backend returns a list of cidades for a regiao
  cidades?: CidadeDto[];
  // novo campo para indicar se a região está ativa
  ativo?: boolean;
}

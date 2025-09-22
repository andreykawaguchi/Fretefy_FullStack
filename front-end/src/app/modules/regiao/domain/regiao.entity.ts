export interface Regiao {
  id: string;
  nome: string;
  cidades?: { id?: string; nome?: string }[];
  ativo?: boolean;
}

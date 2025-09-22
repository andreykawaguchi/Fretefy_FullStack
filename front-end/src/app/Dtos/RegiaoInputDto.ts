export interface RegiaoCidadeInputDto {
  cidadeId: string;
}

export interface CreateRegiaoInput {
  nome: string;
  regiaoCidades?: RegiaoCidadeInputDto[];
}

export interface UpdateRegiaoInput extends CreateRegiaoInput {
  id: string;
}

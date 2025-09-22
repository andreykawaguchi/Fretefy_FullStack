import { RegiaoDto } from '../../Dtos/RegiaoDto';
import { Regiao } from '../../domain/regiao';

export const toDomain = (dto: RegiaoDto): Regiao => {
  return new Regiao({ id: dto.id, nome: dto.nome, cidades: dto.cidades ? dto.cidades.map(c => ({ id: c.id, nome: c.nome, uf: c.uf })) : [], ativo: dto.ativo });
};

export const toDto = (domain: Regiao): RegiaoDto => {
  return { id: domain.id || '', nome: domain.nome, cidades: domain.cidades.map(c => ({ id: c.id, nome: c.nome, uf: c.uf })), ativo: domain.ativo };
};

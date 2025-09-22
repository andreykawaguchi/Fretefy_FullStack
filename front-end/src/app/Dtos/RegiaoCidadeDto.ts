import { CidadeDto } from './CidadeDto';
import { RegiaoDto } from './RegiaoDto';

export interface RegiaoCidadeDto {
  id: string;
  regiaoId: string;
  regiao?: RegiaoDto;
  cidadeId: string;
  cidade?: CidadeDto;
}

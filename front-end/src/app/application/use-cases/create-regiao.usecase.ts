import { Regiao } from '../../domain/regiao';
import { RegiaoService } from '../../services/regiao.service';
import { CreateRegiaoInput } from '../../Dtos/RegiaoInputDto';

export class CreateRegiaoUseCase {
  constructor(private regiaoService: RegiaoService) {}

  async execute(input: CreateRegiaoInput): Promise<{ success: boolean; errors?: string[]; result?: any }> {
    const regiao = new Regiao({ nome: input.nome, cidades: (input.regiaoCidades || []).map(rc => ({ id: rc.cidadeId })) });
    const valid = regiao.isValid();
    if (!valid.valid) return { success: false, errors: valid.errors };

    // delega para o service infra (API client)
    try {
      const created = await this.regiaoService.create(input).toPromise();
      return { success: true, result: created };
    } catch (err: any) {
      return { success: false, errors: [err && err.message ? err.message : 'Erro desconhecido'] };
    }
  }
}

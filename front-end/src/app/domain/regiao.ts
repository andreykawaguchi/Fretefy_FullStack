export class Regiao {
  id?: string;
  nome: string;
  cidades: { id: string; nome?: string; uf?: string }[] = [];
  ativo: boolean = true;

  constructor(props: { id?: string; nome: string; cidades?: { id: string; nome?: string; uf?: string }[]; ativo?: boolean }) {
    this.id = props.id;
    this.nome = props.nome;
    this.cidades = props.cidades || [];
    this.ativo = props.ativo !== undefined ? props.ativo : true;
  }

  validateNome(): string | null {
    if (!this.nome || !this.nome.trim()) return 'Nome é obrigatório.';
    if (this.nome.trim().length < 3) return 'Nome deve ter ao menos 3 caracteres.';
    return null;
  }

  isValid(): { valid: boolean; errors: string[] } {
    const errors: string[] = [];
    const e = this.validateNome();
    if (e) errors.push(e);
    return { valid: errors.length === 0, errors };
  }
}

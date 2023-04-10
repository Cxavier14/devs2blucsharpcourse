export class Contato {
  id?: number;
  name?: string;
  telefone?: string;
  endereco?: string;

  lista?: Contato[];

  constructor(obj: Partial<Contato>) {
    Object.assign(this, obj);
  }
}

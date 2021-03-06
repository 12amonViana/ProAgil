import { Lote } from './Lote';
import { RedeSocial } from './RedeSocial';
import { Palestrante } from './Palestrante';

export interface Evento {
   id: number;
   local: string;
   dataEvento: Date;
   tema: string;
   qtdPessoas: number;
   lote: string;
   imageURL: string;
   telefone: string;
   email: string;
   lotes: Lote[];
   redesSociais: RedeSocial[];
   palestranteEventos: Palestrante[];
}

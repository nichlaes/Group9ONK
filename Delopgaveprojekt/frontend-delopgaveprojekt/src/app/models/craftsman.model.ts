import { ToolBox } from './toolbox.model';

export class Craftsman {

    constructor(
        public HaandvaerkerId: number,
        public HVAnsaettelsedato: Date,
        public HVEfternavn: string,
        public HVFagomraade: string,
        public HVFornavn: string,
        public Vaerktoejskasse: ToolBox[]
    ) { }

}
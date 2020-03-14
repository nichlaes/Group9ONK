export class Tool {

    constructor(
        public VTId: number,
        public VTAnskaffet: Date,
        public VTFabrikat: string,
        public VTModel: string,
        public VTSerienummer: string,
        public VTType: string,
        public LiggerIvtk?: number
    ) { }

}
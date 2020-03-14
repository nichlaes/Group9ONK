import { Tool } from './tool.model';

export class ToolBox {

    constructor(
        public VTKId: number,
        public VTKAnskaffet: Date,
        public VTKFabrikat: string,
        public VTKModel: string,
        public VTKSerienummer: string,
        public VTKFarve: string,
        public Vaerktoej: Tool[],
        public VTKEjesAf?: number
    ) { }

}
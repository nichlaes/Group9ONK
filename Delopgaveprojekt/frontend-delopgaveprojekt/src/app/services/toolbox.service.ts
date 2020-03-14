
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { ToolBox } from '../models/toolbox.model';

@Injectable()
export class ToolBoxService {

    constructor(private http: HttpClient) { }

    getToolBox(toolboxId: number): Observable<ToolBox> {
        const url = environment.ENDPOINT.TOOLBOX + '/' + toolboxId;
        return this.http.get<ToolBox>(url);
    }

    getToolBoxes(): Observable<Array<ToolBox>> {
        const url = environment.ENDPOINT.TOOLBOX
        return this.http.get<Array<ToolBox>>(url);
    }

    updateToolBox(toolId: number, dto: ToolBox): Observable<ToolBox> {
        const url = environment.ENDPOINT.TOOLBOX + '/' + toolId;
        return this.http.put<ToolBox>(url, dto);
    }

    createToolBox(toolBox: ToolBox): Observable<ToolBox> {
        const url = environment.ENDPOINT.TOOLBOX;
        return this.http.post<ToolBox>(url, toolBox);
    }

}




import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Tool } from '../models/tool.model';

@Injectable()
export class ToolService {

    constructor(private http: HttpClient) { }

    getTool(toolId: number): Observable<Tool> {
        const url = environment.ENDPOINT.TOOL + '/' + toolId;
        return this.http.get<Tool>(url);
    }

    getTools(): Observable<Array<Tool>> {
        const url = environment.ENDPOINT.TOOL
        return this.http.get<Array<Tool>>(url);
    }

    updateTool(toolId: number, dto: Tool): Observable<Tool> {
        const url = environment.ENDPOINT.TOOL + '/' + toolId;
        return this.http.put<Tool>(url, dto);
    }

    createTool(tool: Tool): Observable<Tool> {
        const url = environment.ENDPOINT.TOOL;
        return this.http.post<Tool>(url, tool);
    }

}



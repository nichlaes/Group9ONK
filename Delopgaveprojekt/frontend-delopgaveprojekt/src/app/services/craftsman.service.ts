
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Craftsman } from '../models/craftsman.model';

@Injectable()
export class CraftsmanService {

    constructor(private http: HttpClient) { }

    getCraftsman(craftsmanId: number): Observable<Craftsman> {
        const url = environment.ENDPOINT.CRAFTSMAN + '/' + craftsmanId;
        return this.http.get<Craftsman>(url);
    }

    getCraftsmen(): Observable<Array<Craftsman>> {
        const url = environment.ENDPOINT.CRAFTSMAN
        return this.http.get<Array<Craftsman>>(url);
    }

    updateCraftsman(craftsmanId: number, dto: Craftsman): Observable<Craftsman> {
        const url = environment.ENDPOINT.CRAFTSMAN + '/' + craftsmanId;
        return this.http.put<Craftsman>(url, dto);
    }

    createCraftsman(craftsman: Craftsman): Observable<Craftsman> {
        const url = environment.ENDPOINT.CRAFTSMAN;
        return this.http.post<Craftsman>(url, craftsman);
    }

}



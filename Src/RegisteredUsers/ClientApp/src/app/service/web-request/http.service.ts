import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

const httpOptions = {
    headers: new
        HttpHeaders(
            { 'Content-Type': 'application/json' })
};

@Injectable({
    providedIn: 'root'
})

export class HttpService {


    constructor(public httpService: HttpClient) { }

    get<T>(url: string): Observable<T> {

        return this.httpService.get<T>(url, httpOptions);
    }

    post<T>(url: string, model: any): Observable<T> {

        return this.httpService.post<T>(url, model, httpOptions);
    }
}

import { HttpClient } from "@angular/common/http";
import { inject } from "@angular/core";
import { environment } from "@env/environment";
import { Observable, tap } from "rxjs";
import { NotificationService } from "./notification.service";

export abstract class BaseApiService {
  private readonly baseUrl = environment.baseApiUrl;
  private readonly http = inject(HttpClient);
  private readonly notifications = inject(NotificationService);

  protected get(path: string, data?: any): Observable<unknown> {
    return this.http.get(`${this.baseUrl}/${path}`, data).pipe(tap({
      error: err => this.notifications.error(err.error.message)
    }));
  }

  protected post(path: string, data?: any): Observable<unknown> {
    return this.http.post(`${this.baseUrl}/${path}`, data).pipe(tap({
      error: err => this.notifications.error(err.error.message)
    }));
  }

  protected put(path: string, data?: any): Observable<unknown> {
    return this.http.put(`${this.baseUrl}/${path}`, data).pipe(tap({
      error: err => this.notifications.error(err.error.message)
    }));
  }

  protected patch(path: string, data?: any): Observable<unknown> {
    return this.http.patch(`${this.baseUrl}/${path}`, data).pipe(tap({
      error: err => this.notifications.error(err.error.message)
    }));
  }

  protected delete(path: string, data?: any): Observable<unknown> {
    return this.http.delete(`${this.baseUrl}/${path}`, data).pipe(tap({
      error: err => this.notifications.error(err.error.message)
    }));
  }

  protected buildQueryParams(path: string, ...parameters: [name: string, value: string | number | boolean][]): string {
    if (parameters.length === 0){
      return path;
    }
    let queryParams = '';
    parameters.forEach(param => {
      if (param[1] !== null || param[1] !== undefined){
        queryParams = queryParams != ''
        ? `${queryParams}&${param[0]}=${param[1].toString()}`
        : `${param[0]}=${param[1]}`;
      }
    });
    return `${path}?${queryParams}`;
  }
}

import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Productos } from '../models/Productos'
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  
  constructor(private http: HttpClient) { }

  postProductos(request: Productos){
    return this.http.post(environment.products + 'Products/', request)
  }

  readProductos(id: number){
    return this.http.get<any>(environment.products + 'Products/' + id)
  }

  getProductos(){
    return this.http.get<any>(environment.products + 'Products/')
  }

  putProductos(request: Productos){
    return this.http.put(environment.products + 'Products/', request)
  }

  deleteProductos(id: number){
    return this.http.delete(environment.products + 'Products/' + id)
  }
}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
//import { nextTick } from 'process';
import { Productos } from './models/Productos';
import { ProductsService } from './services/products.service';
import { Observable, Observer } from 'rxjs';


@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {
  submitted= false;
  
  form!: FormGroup;
  formSearch!: FormGroup;
  formDelete!: FormGroup;
  public producto!: Productos;
  productos: Productos[] = [];
 
  constructor(private formBuilder: FormBuilder, private productService: ProductsService) {
      
   }

  ngOnInit(): void {
    this.form = this.formBuilder.group({
      id: new FormControl('', Validators.required),
      product: new FormControl('', Validators.required),
      price: new FormControl('', Validators.required),
      stock: new FormControl('', Validators.required)
    });

    this.formSearch = this.formBuilder.group({
      search: new FormControl('', Validators.required)
    });
  }

  onSubmit(){
    this.submitted =true;
  }

  save() {
    var producto = new Productos();
    producto.ProductID = this.form.get('id')?.value;
    producto.ProductName = this.form.get('product')?.value;
    producto.UnitPrice = this.form.get('price')?.value;
    producto.UnitsInStock = this.form.get('stock')?.value;
    this.productService.postProductos(producto).subscribe({
      next: x => {console.log('Todo ok')},
      error: err => console.error('No hermano, se rompió todo', err),
      complete: () => console.log('Finished')
    }
    );
  }

  searchProductos(event: any){
    this.productService.readProductos(event).subscribe(
      resp =>
      {
        this.producto = resp;
      },
      error => {console.log(error)}
    );
  }

  getAll(){
    this.productService.getProductos().subscribe(
      (productos => this.productos = productos)
      //resp => {console.log(resp)},
      //error => {console.log(error)}
    );
  }

  borrarProductos(id: number){
    this.productService.deleteProductos(id).subscribe(
      data => {console.log(data)},
      error => {console.log(error);
      }
    )
  }

  refresh(){
    window.location.reload();
  }

}

import { Component, OnInit } from '@angular/core';
import { Router } from "@angular/router";
import { ProductViewComponent } from '../product-view/product-view.component';
import { Product } from '../../models/product';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {
item: Product;
pid:string;
pname:string;
price:number;
stock:number;
  constructor(private router:Router) { 
    this.item = new Product();
  }

  ngOnInit(): void {
  }
  Store(){
    this.item={
      pid: this.pid,
      pname:this.pname,
      price:this.price,
      stock:this.stock
    }
    localStorage.setItem("pid",this.item.pid);
    localStorage.setItem("pname",this.item.pname);
    localStorage.setItem("price",this.item.price.toString());
    localStorage.setItem("stock",this.item.stock.toString());
    this.router.navigateByUrl('view')
  }

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
  pid:string;
  pname:string;
  price:number;
  stock:number;
  constructor() { 
    this.pid = localStorage.getItem("pid");
    this.pname = localStorage.getItem("pname");
    this.price = Number(localStorage.getItem("price"));
    this.stock = Number(localStorage.getItem("stock"));
  }

  ngOnInit(): void {
  }

}

import { Component } from '@angular/core';
import { forkJoin } from 'rxjs';
import { DataService } from '../data.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent {
  products: any[] = [];
  productCategories: any[] = [];
  error: string = "";

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    // Use forkJoin to make parallel API calls
    forkJoin([
      this.dataService.getData('Product'),
      this.dataService.getData('Product/grouped-with-count')
    ]).subscribe({
      next: (responses) => {
        this.products = responses[0];
        this.productCategories = responses[1];
        
        console.log('Products:', this.products);
        console.log('Product Categories:', this.productCategories);
      },
      error: (err) => {
        console.error(err);
        this.error = "Failed to fetch data.";
      }
    });
  }
}
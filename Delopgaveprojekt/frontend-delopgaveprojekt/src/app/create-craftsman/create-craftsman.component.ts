import { Component, OnInit, Input } from '@angular/core';
import { Craftsman } from '../models/craftsman.model';
import { CraftsmanService } from '../services/craftsman.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-create-craftsman',
  templateUrl: './create-craftsman.component.html',
  styleUrls: ['./create-craftsman.component.css']
})
export class CreateCraftsmanComponent implements OnInit {

  @Input() model: Craftsman = new Craftsman(null, null, null, null, null, null);

  update: boolean = false;

  constructor(private craftsmanService: CraftsmanService, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      let id = params['id'];
      if (id != null) {
        this.craftsmanService.getCraftsman(id).subscribe(res => this.model = res);
        this.update = true;
      }
    });
  }

  onSubmit() {

    if (this.update) {
      this.craftsmanService.updateCraftsman(this.model.HaandvaerkerId, this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    }
    else {
      this.craftsmanService.createCraftsman(this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    }
  }

}

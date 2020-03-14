
import { ToolBox } from '../models/toolbox.model';
import { ToolBoxService } from '../services/toolbox.service';
import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-create-toolbox',
  templateUrl: './create-toolbox.component.html',
  styleUrls: ['./create-toolbox.component.css']
})
export class CreateToolboxComponent implements OnInit {

  @Input() model: ToolBox = new ToolBox(null, null, null, null, null, null, null, null);
  update: boolean = false;

  constructor(private toolBoxService: ToolBoxService, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      let id = params['id'];
      if (id != null) {
        this.toolBoxService.getToolBox(id).subscribe(res => this.model = res);
        this.update = true;
      }
    });
  }

  onSubmit() {
    if (this.update) {
      this.toolBoxService.updateToolBox(this.model.VTKId, this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    }
    else {
      this.toolBoxService.createToolBox(this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    }
  }

}

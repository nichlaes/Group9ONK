import { Component, OnInit, Input } from '@angular/core';
import { Tool } from '../models/tool.model';
import { ToolService } from '../services/tool.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-create-tool',
  templateUrl: './create-tool.component.html',
  styleUrls: ['./create-tool.component.css']
})
export class CreateToolComponent implements OnInit {

  @Input() model: Tool = new Tool(0, null, null, null, null, null, null);

  update: boolean = false;

  constructor(private toolService: ToolService, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.activatedRoute.params.subscribe(params => {
      let id = params['id'];
      if (id != null) {
        this.toolService.getTool(id).subscribe(res => this.model = res);
        this.update = true;
      }
    });
  }

  onSubmit() {

    if (this.update) {
      this.toolService.updateTool(this.model.VTId, this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    } else {
      this.toolService.createTool(this.model).subscribe(res => {
        console.log(res);
      },
        err => console.log(err)
      );
    }
  }

}

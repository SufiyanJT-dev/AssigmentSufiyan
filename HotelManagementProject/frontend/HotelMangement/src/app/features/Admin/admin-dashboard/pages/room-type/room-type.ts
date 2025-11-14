import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-room-type',
  imports: [CommonModule],
  templateUrl: './room-type.html',
  styleUrl: './room-type.scss',
})
export class RoomType {
ngOninit(){

}
roomTypes$!: Observable<RoomType[]>;
  editingId: string | null = null;

  // form = this.fb.group({
  //   typeName: ['', [Validators.required, Validators.maxLength(50)]],
  //   description: ['', [Validators.required, Validators.maxLength(200)]],
  //   capacity: [2, [Validators.required, capacityValidator]],
  // });

  // constructor(private fb: FormBuilder, private service: RoomTypeService) {}

  ngOnInit(): void {
    // this.roomTypes$ = this.service.getAll();
  }

  get f() {
    return ;
  }

  startEdit(room: RoomType): void {
    // this.editingId = room.id;
    // this.form.setValue({
    //   typeName: room.typeName,
    //   description: room.description,
    //   capacity: room.capacity,
    // });
    window.scrollTo({ top: 0, behavior: 'smooth' });
  }

  cancelEdit(): void {
    this.editingId = null;
    // this.form.reset({ typeName: '', description: '', capacity: 2 });
  }

  submit(): void {
    // if (this.form.invalid) {
    //   this.form.markAllAsTouched();
    //   return;
    // }

    // const value = this.form.getRawValue();
    // if (this.editingId) {
    //   this.service.update(this.editingId, value as Omit<RoomType, 'id'>);
    // } else {
    //   this.service.add(value as Omit<RoomType, 'id'>);
    // }
    // this.cancelEdit();
  }

  delete(id: string): void {
    // this.service.delete(id);
    // if (this.editingId===id) this.cancelEdit();
  }
}

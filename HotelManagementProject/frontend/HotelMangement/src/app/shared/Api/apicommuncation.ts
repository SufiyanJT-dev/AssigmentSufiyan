import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { addHotelDeatils } from '../../features/Admin/admin-dashboard/pages/hotel/Type/AddHotelDeatils';
import { RoomType } from '../../features/Admin/admin-dashboard/pages/room-type/room-type';
import { BookingDetails } from '../../features/Admin/admin-dashboard/pages/booking/booking';
@Injectable({
  providedIn: 'root',
})
export class Apicommuncation {
  constructor(private http: HttpClient) { }


  private api = "https://localhost:7119/api/"
  private baseUrl="https://localhost:7119/api/"
  Validation(loginDetails: any): Observable<any> {
    return this.http.post(this.api + 'Employee/validate-login', loginDetails, { withCredentials: true });
  }
  filtering(FilterQuery: any): Observable<any> {
    const params = new HttpParams({ fromObject: FilterQuery })
    return this.http.get(this.api + 'Hotel/filter', { params: params });
  }
  getAllEmployee(): Observable<any> {
    const token = sessionStorage.getItem('JwtToken');
    const headers = new HttpHeaders({
      'Authorization': `Bearer ${token}`
    });
    console.log(headers)
    return this.http.get(this.api + 'Employee', { headers });
  }
  getAllHotel(): Observable<any> {
    const token = sessionStorage.getItem('JwtToken');
    const headers = new HttpHeaders({
      'Authorization': `Bearer ${token}`
    });
    return this.http.get(this.api + 'Hotel', { headers });
  }

  getRefershToken(): Observable<any> {
    const refreshToken = sessionStorage.getItem('refreshToken');
    return this.http.post(this.api + 'Employee/refresh-token', { refreshToken });
  }
  AddHotel(formData: FormData): Observable<any> {
    return this.http.post(this.api + 'Hotel', formData)
  }
  DeleteHotel(id: number): Observable<any> {
    return this.http.delete(`${this.api}Hotel/${id}`);
  }
  UpdateHotel(id: number, formData: FormData): Observable<any> {
    return this.http.patch(`${this.api}Hotel/${id}`, formData);
  }
GetAllRoomsByHotelId(HotelId: number): Observable<any> {
    return this.http.get(`${this.api}Room/hotel/${HotelId}`);
  }
getroomtypesbyId(id: number): Observable<any> {
    return this.http.get(`${this.api}RoomType/${id}`);
}
getAllRoomType():Observable<any>{
   return this.http.get(`${this.api}RoomType`);
}
DeleteRoom(id:number):Observable<any>{
  return this.http.delete(`${this.api}Room/${id}`)
}
UpdateRoom(id:number,formData:FormData):Observable<any>{
  return this.http.patch(`${this.api}Room/${id}`,formData)
}
AddRoom(formData:FormData):Observable<any>{
return this.http.post(`${this.api}Room`,formData)
}
getAllBooking():Observable<any>{
return this.http.get(`${this.api}Booking`);
}
DeleteRoomType(id:number):Observable<any>{
return this.http.delete(`${this.api}RoomType/${id}`,)
}
AddRoomType(formData:RoomType):Observable<any>{
  return this.http.post(`${this.api}RoomType`,formData);
}
UpdateRoomType(id:number,formData:RoomType):Observable<any>{
  return this.http.patch(`${this.api}RoomType/${id}`,formData)
}
// GET all bookings


// GET single booking by ID
getBookingById(id: number): Observable<BookingDetails> {
  return this.http.get<BookingDetails>(`${this.baseUrl}/${id}`);
}

// POST create new booking
createBooking(booking: BookingDetails): Observable<number> {
  return this.http.post<number>(`${this.baseUrl}Booking/`, booking);
}

// PATCH update existing booking
updateBooking(id: number, booking: BookingDetails): Observable<boolean> {
  return this.http.patch<boolean>(`${this.baseUrl}Booking/${id}`, booking);
}

// DELETE booking
deleteBooking(id: number): Observable<boolean> {
  return this.http.delete<boolean>(`${this.baseUrl}Booking/${id}`);
}
}
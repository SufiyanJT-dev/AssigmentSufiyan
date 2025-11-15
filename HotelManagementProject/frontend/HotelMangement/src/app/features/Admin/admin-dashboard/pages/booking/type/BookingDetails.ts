export interface BookingDetails {
  id: number;
  customerId: number | null;
  roomId: number | null;
  checkInDate:   Date | string;
  checkOutDate:   Date | string;
  status: 'PENDING' | 'CONFIRMED' | 'CANCELLED';
  totalAmount: number | null;
}
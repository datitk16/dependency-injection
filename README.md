# dependency-injection

Có lớp class A có sự dụng một chức năng (gọi là gàn nào đó) của class B , lớp B lại tham chiếu gọi các chức năng có trong class C. Ta thấy class A dự vào class B để hoạt động , class
B dựa vào class C. Nếu vậy khi thiết kế theo cách thông thường, viết code thì class A có tham chiếu trực tiếp (cứng) đến class B và trong đó B tham chiếu đến class C.

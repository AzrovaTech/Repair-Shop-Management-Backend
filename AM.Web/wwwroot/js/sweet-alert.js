function confirmDelete(event, el) {
  event.preventDefault();
  Swal.fire({
    title: "آیا از حذف این آیتم مطمعن هستید ؟",
    text: "این عمل بدون بازگشت است !",
    icon: "warning",
    showCancelButton: true,
    confirmButtonColor: "#ff5e00",
    cancelButtonColor: "#3085d6",
    confirmButtonText: "بله, حذف کن",
    cancelButtonText: "انصراف"
  }).then((result) => {
    if (result.isConfirmed) {
        Swal.fire({
            title: "حذف شد!",
            text: "آیتم مورد نظر با موفقیت حذف شد",
            icon: "success",
            confirmButtonText: "باشه"
        }).then(() => {
          window.location.href = el.href;
      });
    }
  });
}
using System.ComponentModel;

namespace KeyOnline.MvcCore.Helper
{
    public enum NapTheEnum
    {
        [Description("Nạp thẻ thành công")]
        ThanhCong = 0,

        [Description("Không tìm thấy Merchant_id")]
        MecanidNotFound = 1,

        [Description("Sai thông tin tài khoản!")]
        Unauthorized = 2,

        [Description("Mã thẻ cào hoặc seri không chính xác")]
        SeriNotCorrect = 3,

        [Description("Thẻ đã sử dụng")]
        Used = 4,

        [Description("Bạn phải nhập seri thẻ")]
        NeedSeri = 5,

        [Description("Thẻ trễ đang chờ duyệt. Liên hệ Admin")]
        Delay = 6,

        [Description("Hệ thống nạp thẻ đang bảo trì")]
        ServerMaintain = 7,

        [Description("Có lỗi xảy ra trong quá trình nạp thẻ. Liên hệ Admin")]
        ErrorGameBank = 8,

        [Description("Thẻ không sử dụng được")]
        NotAbleToUse = 9,

        [Description("Định dạng thẻ không đúng")]
        IncorrectFormat = 10,

        [Description("Nhập sai quá 5 lần, nạp lại sau 2 phút")]
        Incorrect3Time = 11,

        [Description("Lỗi hệ thống. Liên hệ Admin")]
        SystemError = 12,

        [Description("IP không được phép truy cập sau 5 phút")]
        IP5Minute = 13,

        [Description("Có lỗi")]
        WrongUsername = 14,

        [Description("Loại thẻ không đúng")]
        CardTypeIncorrect = 15,

        [Description("Mã thẻ viettel phải có 13 hoặc 15 chữ số")]
        VtCodeNeed13 = 16,

        [Description("Seri viettel phải có 11 hoặc 14 chữ số")]
        VtSeriNeed11 = 17,

        [Description("Mã thẻ mobifone phải có 12 hoặc 15 số")]
        MbCodeneed12 = 18,

        [Description("Seri mobifone phải là 1 dãy số")]
        MbSeri = 19,

        [Description("Seri và mã thẻ vinaphone phải có 14 số")]
        VNCodeNeed12 = 20,

        [Description("Mã thẻ gate có 10 số và seri có 10 ký tự gồm chữ và số")]
        GateNeed10 = 21,

        [Description("Thẻ đã tồn tại trên hệ thống, vui lòng không nạp nữa.")]
        AleradyCharge = 22,

        [Description("Sai thông tin partner")]
        ParrnerIncorrect = 23,

        [Description("Chưa nhận được kết quả trả về từ nhà cung cấp mã thẻ")]
        NotProvider = 24,

        [Description("Dữ liệu truyền vào không đúng")]
        PassingDataIncorrect = 25,

        [Description("Nhà cung cấp không tồn tại")]
        ProviderNotFound = 26,

        [Description("Sai IP")]
        IpIncorrect = 27,

        [Description("Sai session")]
        SessionIncorrect = 28,

        [Description("Session hết hạn")]
        SessionExpire = 29,

        [Description("Thẻ đang chờ duyệt, vui lòng không nạp lại")]
        SystemBusy = 30,

        [Description("Tạm thời khóa kênh nạp VMS do quá tải")]
        VMSOverload = 31,

        [Description("Trùng giao dịch, nạp lại sau ít phút")]
        Duplicate = 32,

        [Description("Seri hoặc mã thẻ không đúng")]
        SeriOrCodeIncorrect = 33,

        [Description("Tài khoản tạm thời bị khóa nạp thẻ")]
        CardLocked = 34,

        [Description("Mã thẻ và Mã seri phải có 12 ký tự gồm chữ và số")]
        CodeOrSeriNeed12Char = 35,

        [Description("Tài khoản của bạn chưa thiết lập IP hoặc chưa được duyệt")]
        AccountInvalid = 36,

        [Description("IP hiện tại không thuộc sở hữu hoặc trong danh sách cho phép của bạn")]
        IPInvalid = 37,

        [Description("Thẻ VTC không còn được hỗ trợ")]
        VTCNotsupported = 38,

        [Description("Loại thẻ đang bảo trì, nạp lại sau ít phút!")]
        CardMaintain = 39,

        [Description("Tài khoản của bạn đang bị khóa!")]
        AccountLocked = 40,

        [Description("Mã thẻ Garena phải có 16 số và seri có 9 số")]
        GarenaEror = 41,

        [Description("Mã thẻ Vcoin phải có 12 ký tự và seri có 12 ký tự")]
        VcoinError = 42,

        [Description("Mã thẻ VNM phải có 12 số và seri có 11 số")]
        VNMError = 43,

        [Description("Mã thẻ Zing phải có 9 ký tự và seri có 12 ký tự")]
        ZingError = 44,

        [Description("Mã thẻ Megacard phải có 12 ký tự và seri có 12 ký tự")]
        MegacardError = 45,

        [Description("Mã thẻ Oncash phải có 12 ký tự và seri có từ 10 đến 12 ký tự")]
        OncashError = 46,

        [Description("Ip address bị khóa nạp thẻ")]
        IpAddressLock = 47,

        [Description("Thẻ trễ nạp thất bại")]
        DelayFail = 48,

        [Description("Thẻ trễ nạp thành công")]
        DelaySuccess = 49,

        [Description("Thẻ không được cộng tiền do khai báo sai seri, mệnh giá")]
        VlError = 50,

        [Description("Hiện tại không nhận mệnh giá này, vui lòng nạp lại sau")]
        NotFoundPrice = 51,

        [Description("Vui lòng thực hiện lại thao tác'")]
        DoItAgain = 52,

        [Description("Thẻ đã nạp sang hệ thống, vui lòng không nạp lại")]
        DoNotAgain = 53,

        [Description("Thẻ bị phạt 10% do khai báo sai mệnh giá")]
        Pen10Percent = 54,

        [Description("Seri bị chặn")]
        SeriLocked = 55,

        [Description("Thẻ đã sử dụng")]
        CardUsed = -1,

        [Description("Thẻ đã bị khóa")]
        CardLockeded = -2,
        [Description("Thẻ hết hạn sử dụng")]
        CardExpire = -3,
        [Description("Thẻ chưa kích hoạt")]
        CardNotActive = -4,
        [Description("Giao dịch không hợp lệ")]
        SessionInvalid = -5,
        [Description("Mã thẻ và số Serial không khớp")]
        SeriAndCodeNotMatch = -6,
        [Description("Cảnh báo số lần giao dịch lỗi của một tài khoản")]
        SesssionError = -8,

        [Description("Thẻ thử quá số lần cho phép")]
        TryManyTime = -9,

        [Description("Mã seri không hợp lệ")]
        SeriInvalid = -10,

        [Description("Mã thẻ không hợp lệ")]
        CodeInvalid = -11,

        [Description(" Thẻ không tồn tại hoặc đã sử dụng")]
        CardNotFound = -12,

        [Description("Mệnh giá thẻ không đúng")]
        StructureIncorrect = -13,

        [Description("Chưa chọn mệnh giá thẻ.")]
        ServiceCodeNotExist = -14,

        [Description("Hiện tại chỉ chấp nhận thẻ Viettel 10,20,30,50,100,200,300,500,1tr")]
        LackCustomerInfo = -15,

        [Description("Hiện tại chỉ chấp nhận thẻ Vinaphone 10,20,30,50,100,200,300,500")]
        SessionCocdeInvalid = -16,

        [Description("Hiện tại chỉ chấp nhận thẻ Garena 20,50,100,200,500")]
        NotAllow1 = -17,

        [Description("Hiện tại chỉ chấp nhận thẻ mMobifone 20,30,50,100,200,500")]
        NotAllow2 = -18,

        [Description("Sai tên hàm")]
        FunctionNameIncorrect = -90,

        [Description("Giao dịch thất bại do Lỗi hệ thống")]
        SessionFaild = -98,
        [Description("Giao dịch thất bại do Lỗi hệ thống")]
        SessionFaild2 = -99,

        [Description("Giao dịch nghi vấn")]
        NotAllow3 = -100,

        [Description("Quá nhiều request đồng thời")]
        NotAllow4 = -101,

        [Description("Hệ thống tạm thời bận")]
        SystemBusy2 = -999,
    }
}

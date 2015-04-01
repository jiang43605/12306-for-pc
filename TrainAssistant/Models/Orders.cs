using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainAssistant.Models
{
    /// <summary>
    /// 订单
    /// </summary>
    public class Orders
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string SequenceNo { get; set; }

        /// <summary>
        /// 订单时间
        /// </summary>
        public string OrderDate { get; set; }

        /// <summary>
        /// 车票数量
        /// </summary>
        public string TicketTotalNum { get; set; }

        /// <summary>
        /// 取消标示
        /// </summary>
        public string CancelFlag { get; set; }

        /// <summary>
        /// 放弃标示
        /// </summary>
        public string ResignFlag { get; set; }

        /// <summary>
        /// 退票标示
        /// </summary>
        public string ReturnFlag { get; set; }

        /// <summary>
        /// 车票打印标示
        /// </summary>
        public string PrintTicketFlag { get; set; }

        /// <summary>
        /// 支付标示
        /// </summary>
        public string PayFlag { get; set; }

        /// <summary>
        /// 放弃支付标示
        /// </summary>
        public string PayResignFlag { get; set; }

        /// <summary>
        /// 确认标示
        /// </summary>
        public string ConfirmFlag { get; set; }

        /// <summary>
        /// 预订标示查询
        /// </summary>
        public string ReserveFlagQuery { get; set; }

        /// <summary>
        /// 显示放弃中的信息
        /// </summary>
        public string IfShowResigningInfo { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        public string RecordCount { get; set; }

        /// <summary>
        /// 是否需要发送邮件和消息
        /// </summary>
        public string IsNeedSendMailAndMsg { get; set; }

        /// <summary>
        /// 乘客
        /// </summary>
        public string PassserNames { get; set; }

        /// <summary>
        /// 出发站
        /// </summary>
        public string FromStationNames { get; set; }

        /// <summary>
        /// 目的地
        /// </summary>
        public string ToStationNames { get; set; }

        /// <summary>
        /// 发车日期
        /// </summary>
        public string StartTrainDate { get; set; }

        /// <summary>
        /// 发车时间
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public string ArriveTime { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        public string TrainCode { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        public string TrainPrice { get; set; }

        /// <summary>
        /// 旅行订单
        /// </summary>
        public string ComeGoTravellerOrder { get; set; }

        public string CanOffLinePay { get; set; }

        public string IfDeliver { get; set; }
    }
}

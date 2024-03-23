﻿using Factory_Method.Channels;
using System.Text;

namespace Factory_Method.Services.SubscriptionService.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public double MonthPayment { get; set; }
        public TimeSpan MinimumSubscribePeriod { get; set; }
        public List<IChannel> Channels { get; set; }

        public DomesticSubscription() : this(0, new(), new()) { }

        public DomesticSubscription(double monthPayment, TimeSpan minimumSubscribePeriod, List<IChannel> channels)
        {
            MonthPayment = monthPayment;
            MinimumSubscribePeriod = minimumSubscribePeriod;
            Channels = channels;
        }

        public string GetInfo()
        {
            StringBuilder builder = new();

            builder.AppendLine("Domestic subscription: ");
            builder.AppendLine($"Month payment: {MonthPayment}");
            builder.AppendLine($"Amount of channels: {Channels.Count}");

            foreach (var channel in Channels)
            {
                builder.AppendLine(channel.Name);
            }

            return builder.ToString();
        }
    }
}

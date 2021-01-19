/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Volume : AbstractModel
    {
        
        /// <summary>
        /// Date
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SendDate")]
        public string SendDate{ get; set; }

        /// <summary>
        /// Number of email requests.
        /// </summary>
        [JsonProperty("RequestCount")]
        public ulong? RequestCount{ get; set; }

        /// <summary>
        /// Number of email requests accepted by Tencent Cloud.
        /// </summary>
        [JsonProperty("AcceptedCount")]
        public ulong? AcceptedCount{ get; set; }

        /// <summary>
        /// Number of delivered emails.
        /// </summary>
        [JsonProperty("DeliveredCount")]
        public ulong? DeliveredCount{ get; set; }

        /// <summary>
        /// Number of users (deduplicated) who opened emails.
        /// </summary>
        [JsonProperty("OpenedCount")]
        public ulong? OpenedCount{ get; set; }

        /// <summary>
        /// Number of recipients who clicked on links in emails.
        /// </summary>
        [JsonProperty("ClickedCount")]
        public ulong? ClickedCount{ get; set; }

        /// <summary>
        /// Number of bounced emails.
        /// </summary>
        [JsonProperty("BounceCount")]
        public ulong? BounceCount{ get; set; }

        /// <summary>
        /// Number of users who canceled subscriptions.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UnsubscribeCount")]
        public ulong? UnsubscribeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SendDate", this.SendDate);
            this.SetParamSimple(map, prefix + "RequestCount", this.RequestCount);
            this.SetParamSimple(map, prefix + "AcceptedCount", this.AcceptedCount);
            this.SetParamSimple(map, prefix + "DeliveredCount", this.DeliveredCount);
            this.SetParamSimple(map, prefix + "OpenedCount", this.OpenedCount);
            this.SetParamSimple(map, prefix + "ClickedCount", this.ClickedCount);
            this.SetParamSimple(map, prefix + "BounceCount", this.BounceCount);
            this.SetParamSimple(map, prefix + "UnsubscribeCount", this.UnsubscribeCount);
        }
    }
}


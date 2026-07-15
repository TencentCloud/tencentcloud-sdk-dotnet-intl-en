/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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
        /// <p>Date</p>
        /// </summary>
        [JsonProperty("SendDate")]
        public string SendDate{ get; set; }

        /// <summary>
        /// <p>Request quantity by email</p>
        /// </summary>
        [JsonProperty("RequestCount")]
        public ulong? RequestCount{ get; set; }

        /// <summary>
        /// <p>Tencent Cloud pass count</p>
        /// </summary>
        [JsonProperty("AcceptedCount")]
        public ulong? AcceptedCount{ get; set; }

        /// <summary>
        /// <p>Delivery quantity</p>
        /// </summary>
        [JsonProperty("DeliveredCount")]
        public ulong? DeliveredCount{ get; set; }

        /// <summary>
        /// <p>Total number of times emails were opened</p>
        /// </summary>
        [JsonProperty("OpenedCount")]
        public ulong? OpenedCount{ get; set; }

        /// <summary>
        /// <p>Number of users who clicked the link in the mail</p>
        /// </summary>
        [JsonProperty("ClickedCount")]
        public ulong? ClickedCount{ get; set; }

        /// <summary>
        /// <p>Bounced count</p>
        /// </summary>
        [JsonProperty("BounceCount")]
        public ulong? BounceCount{ get; set; }

        /// <summary>
        /// <p>Number of users for unsubscription</p>
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


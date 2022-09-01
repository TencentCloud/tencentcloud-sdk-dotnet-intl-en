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

namespace TencentCloud.Ip.V20210409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryCustomersCreditData : AbstractModel
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Phone
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// Overdue payment flag
        /// </summary>
        [JsonProperty("Arrears")]
        public string Arrears{ get; set; }

        /// <summary>
        /// Binding time
        /// </summary>
        [JsonProperty("AssociationTime")]
        public string AssociationTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("RecentExpiry")]
        public string RecentExpiry{ get; set; }

        /// <summary>
        /// The UIN of reseller’s customer
        /// </summary>
        [JsonProperty("ClientUin")]
        public ulong? ClientUin{ get; set; }

        /// <summary>
        /// Credit granted to reseller’s customer
        /// </summary>
        [JsonProperty("Credit")]
        public float? Credit{ get; set; }

        /// <summary>
        /// The remaining credit of reseller’s customer
        /// </summary>
        [JsonProperty("RemainingCredit")]
        public float? RemainingCredit{ get; set; }

        /// <summary>
        /// 0: Identity not verified; 1: Individual identity verified; 2: Enterprise identity verified.
        /// </summary>
        [JsonProperty("IdentifyType")]
        public ulong? IdentifyType{ get; set; }

        /// <summary>
        /// Customer remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Forced status
        /// </summary>
        [JsonProperty("Force")]
        public long? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Arrears", this.Arrears);
            this.SetParamSimple(map, prefix + "AssociationTime", this.AssociationTime);
            this.SetParamSimple(map, prefix + "RecentExpiry", this.RecentExpiry);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "Credit", this.Credit);
            this.SetParamSimple(map, prefix + "RemainingCredit", this.RemainingCredit);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}


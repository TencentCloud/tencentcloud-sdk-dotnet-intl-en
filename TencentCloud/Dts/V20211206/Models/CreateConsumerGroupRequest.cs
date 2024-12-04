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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConsumerGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Subscription instance ID
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Consumer group name, which consists of numbers, letters (upper and lower case), or begins with _ - . Ends with numbers, letters (upper and lower case). The full name of the actually generated consumer group is in the form: consumer-grp-#{SubscribeId}-#{ConsumerGroupName}.
        /// </summary>
        [JsonProperty("ConsumerGroupName")]
        public string ConsumerGroupName{ get; set; }

        /// <summary>
        /// Account name, which consists of numbers, letters (upper and lower case), or begins with _-.. Ends with numbers, letters (upper and lower case). The full name of the actually generated account is in the form: account-#{SubscribeId}-#{AccountName}.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// Consumer group password, which should be longer than 3 characters.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Consumer group description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "ConsumerGroupName", this.ConsumerGroupName);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}


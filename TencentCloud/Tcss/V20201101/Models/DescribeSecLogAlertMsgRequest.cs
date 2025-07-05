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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecLogAlertMsgRequest : AbstractModel
    {
        
        /// <summary>
        /// Alert type
        /// Log storage alert: log_reserve_full
        /// Log storage period alert: log_save_day_limit
        /// Unavailable Kafka instance/public domain name: kafka_instance_domain_unavailable
        /// Incorrect Kafka username/password: kafka_user_passwd_wrong
        /// Kafka backend error field: kafka_field_wrong
        /// </summary>
        [JsonProperty("Type")]
        public string[] Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Type.", this.Type);
        }
    }
}


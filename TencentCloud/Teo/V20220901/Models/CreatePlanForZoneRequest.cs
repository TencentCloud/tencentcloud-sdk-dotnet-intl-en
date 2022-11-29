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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePlanForZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The plan option. Values:
        /// <li>`sta`: Standard plan that supports content delivery network outside the Chinese mainland.</li>
        /// <li>`sta_with_bot`: Standard plan that supports content delivery network outside the Chinese mainland and bot management.</li>
        /// <li>`sta_cm`: Standard plan that supports content delivery network inside the Chinese mainland.</li>
        /// <li>`sta_cm_with_bot`: Standard plan that supports content delivery network inside the Chinese mainland and bot management.</li>
        /// <li>`sta_global`: Standard plan that supports content delivery network over the globe.</li>
        /// <li>`sta_global_with_bot`: Standard plan that supports content delivery network over the globe and bot management.</li>
        /// <li>`ent`: Enterprise plan that supports content delivery network outside the Chinese mainland.</li>
        /// <li>`ent_with_bot`: Enterprise plan that supports content delivery network outside the Chinese mainland and bot management.</li>
        /// <li>`ent_cm`: Enterprise plan that supports content delivery network inside the Chinese mainland.</li>
        /// <li>`ent_cm_with_bot`: Enterprise plan that supports content delivery network inside the Chinese mainland and bot management.</li>
        /// <li>`ent_global`: Enterprise plan that supports content delivery network over the globe.</li>
        /// <li>`ent_global_with_bot`: Enterprise plan that supports content delivery network over the globe and bot management.</li>To get the available plan options for your account, view the output from <a href="https://tcloud4api.woa.com/document/product/1657/80124?!preview&!document=1">DescribeAvailablePlans</a>.
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
        }
    }
}


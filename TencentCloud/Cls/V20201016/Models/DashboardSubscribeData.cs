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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DashboardSubscribeData : AbstractModel
    {
        
        /// <summary>
        /// Dashboard subscription notification method.
        /// </summary>
        [JsonProperty("NoticeModes")]
        public DashboardNoticeMode[] NoticeModes{ get; set; }

        /// <summary>
        /// Dashboard subscription time. If this field is empty, the dashboard default time is used.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DashboardTime")]
        public string[] DashboardTime{ get; set; }

        /// <summary>
        /// Dashboard subscription template variable.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TemplateVariables")]
        public DashboardTemplateVariable[] TemplateVariables{ get; set; }

        /// <summary>
        /// Time zone. Refer to: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones#SHANGHAI.
        /// </summary>
        [JsonProperty("Timezone")]
        public string Timezone{ get; set; }

        /// <summary>
        /// Language. zh: Chinese; en: English.
        /// </summary>
        [JsonProperty("SubscribeLanguage")]
        public string SubscribeLanguage{ get; set; }

        /// <summary>
        /// Call link domain name. It must start with http:// or https:// and must not end with /.
        /// </summary>
        [JsonProperty("JumpDomain")]
        public string JumpDomain{ get; set; }

        /// <summary>
        /// Custom redirection link.
        /// </summary>
        [JsonProperty("JumpUrl")]
        public string JumpUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NoticeModes.", this.NoticeModes);
            this.SetParamArraySimple(map, prefix + "DashboardTime.", this.DashboardTime);
            this.SetParamArrayObj(map, prefix + "TemplateVariables.", this.TemplateVariables);
            this.SetParamSimple(map, prefix + "Timezone", this.Timezone);
            this.SetParamSimple(map, prefix + "SubscribeLanguage", this.SubscribeLanguage);
            this.SetParamSimple(map, prefix + "JumpDomain", this.JumpDomain);
            this.SetParamSimple(map, prefix + "JumpUrl", this.JumpUrl);
        }
    }
}


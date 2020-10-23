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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimeRange : AbstractModel
    {
        
        /// <summary>
        /// <li>After or at this time (start time).</li>
        /// <li>In ISO 8601 format. For more information, please see [ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("After")]
        public string After{ get; set; }

        /// <summary>
        /// <li>Before or at this time (end time).</li>
        /// <li>In ISO 8601 format. For more information, please see [ISO Date Format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).</li>
        /// </summary>
        [JsonProperty("Before")]
        public string Before{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "After", this.After);
            this.SetParamSimple(map, prefix + "Before", this.Before);
        }
    }
}


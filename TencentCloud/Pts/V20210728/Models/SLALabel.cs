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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SLALabel : AbstractModel
    {
        
        /// <summary>
        /// Label name.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Label value.
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("LabelValue")]
        public string LabelValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "LabelValue", this.LabelValue);
        }
    }
}


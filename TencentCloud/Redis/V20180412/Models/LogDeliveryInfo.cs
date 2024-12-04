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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogDeliveryInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether log shipping is enabled. true: enabled; false: disabled.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Logset ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// Log topic ID.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Logset region
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LogRegion")]
        public string LogRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "LogRegion", this.LogRegion);
        }
    }
}


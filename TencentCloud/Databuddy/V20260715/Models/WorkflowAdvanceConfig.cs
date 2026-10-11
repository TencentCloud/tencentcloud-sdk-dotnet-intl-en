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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowAdvanceConfig : AbstractModel
    {
        
        /// <summary>
        /// Queue mode. ON (default) and OFF.
        /// </summary>
        [JsonProperty("QueuingMode")]
        public string QueuingMode{ get; set; }

        /// <summary>
        /// 	
        /// The default value is 1.
        /// 
        /// When QueuingMode is ON, the MaxConcurrentNum setting takes effect. Input only integers larger than 0. Invalid input is automatically converted to 1.
        /// </summary>
        [JsonProperty("MaxConcurrentNum")]
        public long? MaxConcurrentNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueuingMode", this.QueuingMode);
            this.SetParamSimple(map, prefix + "MaxConcurrentNum", this.MaxConcurrentNum);
        }
    }
}


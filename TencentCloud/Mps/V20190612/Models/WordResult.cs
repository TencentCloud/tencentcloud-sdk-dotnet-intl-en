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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WordResult : AbstractModel
    {
        
        /// <summary>
        /// Word text.
        /// </summary>
        [JsonProperty("Word")]
        public string Word{ get; set; }

        /// <summary>
        /// Word start timestamp, in seconds.
        /// </summary>
        [JsonProperty("Start")]
        public float? Start{ get; set; }

        /// <summary>
        /// Word end timestamp, in seconds.
        /// </summary>
        [JsonProperty("End")]
        public float? End{ get; set; }

        /// <summary>
        /// Text after translation.
        /// </summary>
        [JsonProperty("Trans")]
        public string Trans{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Word", this.Word);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
            this.SetParamSimple(map, prefix + "Trans", this.Trans);
        }
    }
}


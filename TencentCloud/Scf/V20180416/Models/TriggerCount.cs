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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerCount : AbstractModel
    {
        
        /// <summary>
        /// Number of COS triggers
        /// </summary>
        [JsonProperty("Cos")]
        public long? Cos{ get; set; }

        /// <summary>
        /// Number of timer triggers
        /// </summary>
        [JsonProperty("Timer")]
        public long? Timer{ get; set; }

        /// <summary>
        /// Number of CMQ triggers
        /// </summary>
        [JsonProperty("Cmq")]
        public long? Cmq{ get; set; }

        /// <summary>
        /// Total number of triggers
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// Number of CKafka triggers
        /// </summary>
        [JsonProperty("Ckafka")]
        public long? Ckafka{ get; set; }

        /// <summary>
        /// Number of API Gateway triggers
        /// </summary>
        [JsonProperty("Apigw")]
        public long? Apigw{ get; set; }

        /// <summary>
        /// Number of CLS triggers
        /// </summary>
        [JsonProperty("Cls")]
        public long? Cls{ get; set; }

        /// <summary>
        /// Number of CLB triggers
        /// </summary>
        [JsonProperty("Clb")]
        public long? Clb{ get; set; }

        /// <summary>
        /// Number of MPS triggers
        /// </summary>
        [JsonProperty("Mps")]
        public long? Mps{ get; set; }

        /// <summary>
        /// Number of CM triggers
        /// </summary>
        [JsonProperty("Cm")]
        public long? Cm{ get; set; }

        /// <summary>
        /// Number of VOD triggers
        /// </summary>
        [JsonProperty("Vod")]
        public long? Vod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cos", this.Cos);
            this.SetParamSimple(map, prefix + "Timer", this.Timer);
            this.SetParamSimple(map, prefix + "Cmq", this.Cmq);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Ckafka", this.Ckafka);
            this.SetParamSimple(map, prefix + "Apigw", this.Apigw);
            this.SetParamSimple(map, prefix + "Cls", this.Cls);
            this.SetParamSimple(map, prefix + "Clb", this.Clb);
            this.SetParamSimple(map, prefix + "Mps", this.Mps);
            this.SetParamSimple(map, prefix + "Cm", this.Cm);
            this.SetParamSimple(map, prefix + "Vod", this.Vod);
        }
    }
}


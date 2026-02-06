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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class APPOverviewData : AbstractModel
    {
        
        /// <summary>
        /// Superapp active device count
        /// </summary>
        [JsonProperty("AllActiveDeviceNum")]
        public long? AllActiveDeviceNum{ get; set; }

        /// <summary>
        /// Superapp new device count
        /// </summary>
        [JsonProperty("AllNewDeviceNum")]
        public long? AllNewDeviceNum{ get; set; }

        /// <summary>
        /// Mini program team count
        /// </summary>
        [JsonProperty("CorpNum")]
        public long? CorpNum{ get; set; }

        /// <summary>
        /// Mini game active device count
        /// </summary>
        [JsonProperty("GameActiveDeviceNum")]
        public long? GameActiveDeviceNum{ get; set; }

        /// <summary>
        /// Mini game new device count
        /// </summary>
        [JsonProperty("GameNewDeviceNum")]
        public long? GameNewDeviceNum{ get; set; }

        /// <summary>
        /// Created mini program count
        /// </summary>
        [JsonProperty("MiniAppNum")]
        public long? MiniAppNum{ get; set; }

        /// <summary>
        /// Created mini game count
        /// </summary>
        [JsonProperty("MngNum")]
        public long? MngNum{ get; set; }

        /// <summary>
        /// Mini program new device count
        /// </summary>
        [JsonProperty("NewDeviceNum")]
        public long? NewDeviceNum{ get; set; }

        /// <summary>
        /// Released mini program count
        /// </summary>
        [JsonProperty("OnlineMiniAppNum")]
        public long? OnlineMiniAppNum{ get; set; }

        /// <summary>
        /// Released mini game count
        /// </summary>
        [JsonProperty("OnlineMngNum")]
        public long? OnlineMngNum{ get; set; }

        /// <summary>
        /// Mini program active device count
        /// </summary>
        [JsonProperty("VisitNum")]
        public long? VisitNum{ get; set; }

        /// <summary>
        /// Data refresh timestamp
        /// </summary>
        [JsonProperty("FlushTime")]
        public string FlushTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllActiveDeviceNum", this.AllActiveDeviceNum);
            this.SetParamSimple(map, prefix + "AllNewDeviceNum", this.AllNewDeviceNum);
            this.SetParamSimple(map, prefix + "CorpNum", this.CorpNum);
            this.SetParamSimple(map, prefix + "GameActiveDeviceNum", this.GameActiveDeviceNum);
            this.SetParamSimple(map, prefix + "GameNewDeviceNum", this.GameNewDeviceNum);
            this.SetParamSimple(map, prefix + "MiniAppNum", this.MiniAppNum);
            this.SetParamSimple(map, prefix + "MngNum", this.MngNum);
            this.SetParamSimple(map, prefix + "NewDeviceNum", this.NewDeviceNum);
            this.SetParamSimple(map, prefix + "OnlineMiniAppNum", this.OnlineMiniAppNum);
            this.SetParamSimple(map, prefix + "OnlineMngNum", this.OnlineMngNum);
            this.SetParamSimple(map, prefix + "VisitNum", this.VisitNum);
            this.SetParamSimple(map, prefix + "FlushTime", this.FlushTime);
        }
    }
}


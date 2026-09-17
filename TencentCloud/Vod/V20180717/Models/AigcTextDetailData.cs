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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcTextDetailData : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ChatId")]
        public string ChatId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong? StatusCode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InputTokens")]
        public long? InputTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputTokens")]
        public long? OutputTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CacheInputTokens")]
        public long? CacheInputTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TPS")]
        public float? TPS{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("TTFT")]
        public float? TTFT{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Total")]
        public float? Total{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
            this.SetParamSimple(map, prefix + "ChatId", this.ChatId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "CacheInputTokens", this.CacheInputTokens);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "TPS", this.TPS);
            this.SetParamSimple(map, prefix + "TTFT", this.TTFT);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
        }
    }
}


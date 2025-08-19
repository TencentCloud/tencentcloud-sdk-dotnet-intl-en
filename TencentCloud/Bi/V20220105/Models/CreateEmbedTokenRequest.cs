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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateEmbedTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// Shares the project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Shares the page ID. This field is empty (0) for embedding a dashboard and is not passed for embedding ChatBI.
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// "embed" indicates page dashboard embedding, and "chatBIEmbed" indicates ChatBI embedding.
        /// </summary>
        [JsonProperty("Intention")]
        public string Intention{ get; set; }

        /// <summary>
        /// "page" indicates embedding a page, "panel" indicates embedding the entire dashboard, and "project" is used for ChatBI embedding.
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// Expiration time. Unit: minutes. Maximum value: 240 (namely, 4 hours). Default value: 240.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Alternate field.
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// User enterprise ID (only used for multi-user).
        /// </summary>
        [JsonProperty("UserCorpId")]
        public string UserCorpId{ get; set; }

        /// <summary>
        /// User ID (only used for multi-user).
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Access count limit (range: 1-99999). Leave empty to disable access restrictions.
        /// </summary>
        [JsonProperty("TicketNum")]
        public long? TicketNum{ get; set; }

        /// <summary>
        /// Global filter parameters: Applies to all report filter criteria. Should be formatted as a JSON string.
        /// ** Currently, only character-type page parameters can be bound to global parameters.
        /// **
        /// [
        ///     {
        /// "ParamKey": "name", page parameter name.
        /// "JoinType": "AND", // connection method. Currently, only AND is supported.
        ///         "WhereList": [
        ///             {
        /// "Operator": "-neq", // operator. Refer to the following instructions.
        /// "Value": [ action value. For a single-value array, only one value is passed.
        ///                     "zZWJMD",
        ///                     "ZzVGHX",
        /// "Hunan province".
        /// "Hebei province".
        ///                 ]
        ///             }
        ///         ]
        ///     },
        ///     {
        ///         "ParamKey": "genderParam",
        ///         "JoinType": "AND",
        ///         "WhereList": [
        ///             {
        ///                 "Operator": "-neq",
        ///                 "Value": [
        /// "Male".
        ///                 ]
        ///             }
        ///         ]
        ///     }
        /// ]
        /// 
        /// 
        /// 
        /// Currently supported operators.
        ///  -neq not equal to != operator.
        ///  -eq equal to = operator.
        ///  -is in operator.
        /// </summary>
        [JsonProperty("GlobalParam")]
        public string GlobalParam{ get; set; }

        /// <summary>
        /// 100: no user bound. Create 1 token at a time. UserCorpId and UserId are optional. ChatBI embedding is not supported.
        /// 200: single token per user. Create 1 token at a time. UserCorpId and UserId required.
        /// 300: multiple tokens per user. Create multiple tokens at a time. UserCorpId and UserId required.
        /// </summary>
        [JsonProperty("TokenType")]
        public long? TokenType{ get; set; }

        /// <summary>
        /// The number of tokens created at one time.
        /// </summary>
        [JsonProperty("TokenNum")]
        public long? TokenNum{ get; set; }

        /// <summary>
        /// Embedded display configurations: Currently for ChatBI embedding scenarios; TableFilter represents data table list filtering, SqlView represents SQL view feature.
        /// </summary>
        [JsonProperty("ConfigParam")]
        public string ConfigParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "Intention", this.Intention);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "UserCorpId", this.UserCorpId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "TicketNum", this.TicketNum);
            this.SetParamSimple(map, prefix + "GlobalParam", this.GlobalParam);
            this.SetParamSimple(map, prefix + "TokenType", this.TokenType);
            this.SetParamSimple(map, prefix + "TokenNum", this.TokenNum);
            this.SetParamSimple(map, prefix + "ConfigParam", this.ConfigParam);
        }
    }
}


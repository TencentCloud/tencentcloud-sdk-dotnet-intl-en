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

    public class ApiDatasourceConfig : AbstractModel
    {
        
        /// <summary>
        /// API data source parsing result
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FieldsJsonData")]
        public string FieldsJsonData{ get; set; }

        /// <summary>
        /// Connection Type 1: Direct Connection 2: Extraction
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConnectionType")]
        public ulong? ConnectionType{ get; set; }

        /// <summary>
        /// Extraction frequency configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FrequencyConfig")]
        public FrequencyConfig FrequencyConfig{ get; set; }

        /// <summary>
        /// Request URL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 1:GET 2:POST
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestMethod")]
        public ulong? RequestMethod{ get; set; }

        /// <summary>
        /// Request headers
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestHeader")]
        public string RequestHeader{ get; set; }

        /// <summary>
        /// Request parameter
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestParams")]
        public string RequestParams{ get; set; }

        /// <summary>
        /// request body
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestBody")]
        public string RequestBody{ get; set; }

        /// <summary>
        /// Username.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Password.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Valid values: 1: no authentication; 2: BASIC_AUTH.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthorizationType")]
        public ulong? AuthorizationType{ get; set; }

        /// <summary>
        /// Table ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TableId")]
        public ulong? TableId{ get; set; }

        /// <summary>
        /// Mapping path DbName
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JsonPathDbNameMap")]
        public string JsonPathDbNameMap{ get; set; }

        /// <summary>
        /// Authentication API
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthApi")]
        public string AuthApi{ get; set; }

        /// <summary>
        /// Application Key
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// application key
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppSecret")]
        public string AppSecret{ get; set; }

        /// <summary>
        /// Data Key
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Data key initialization vector
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecretIv")]
        public string SecretIv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldsJsonData", this.FieldsJsonData);
            this.SetParamSimple(map, prefix + "ConnectionType", this.ConnectionType);
            this.SetParamObj(map, prefix + "FrequencyConfig.", this.FrequencyConfig);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "RequestMethod", this.RequestMethod);
            this.SetParamSimple(map, prefix + "RequestHeader", this.RequestHeader);
            this.SetParamSimple(map, prefix + "RequestParams", this.RequestParams);
            this.SetParamSimple(map, prefix + "RequestBody", this.RequestBody);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "AuthorizationType", this.AuthorizationType);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "JsonPathDbNameMap", this.JsonPathDbNameMap);
            this.SetParamSimple(map, prefix + "AuthApi", this.AuthApi);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "AppSecret", this.AppSecret);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "SecretIv", this.SecretIv);
        }
    }
}


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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSparkAppRequest : AbstractModel
    {
        
        /// <summary>
        /// The Spark job name.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// The Spark job type. Valid values: `1` for Spark JAR job and `2` for Spark streaming job.
        /// </summary>
        [JsonProperty("AppType")]
        public long? AppType{ get; set; }

        /// <summary>
        /// The data engine executing the Spark job.
        /// </summary>
        [JsonProperty("DataEngine")]
        public string DataEngine{ get; set; }

        /// <summary>
        /// The path of the Spark job package.
        /// </summary>
        [JsonProperty("AppFile")]
        public string AppFile{ get; set; }

        /// <summary>
        /// Data visiting policy achieved through CAM Role arn; the console can obtain it through Data Job -> Job Configuration; SDK can obtain corresponding values through the DescribeUserRoles API.
        /// </summary>
        [JsonProperty("RoleArn")]
        public long? RoleArn{ get; set; }

        /// <summary>
        /// The driver size. Valid values: `small` (default, 1 CU), `medium` (2 CUs), `large` (4 CUs), and `xlarge` (8 CUs).
        /// </summary>
        [JsonProperty("AppDriverSize")]
        public string AppDriverSize{ get; set; }

        /// <summary>
        /// The executor size. Valid values: `small` (default, 1 CU), `medium` (2 CUs), `large` (4 CUs), and `xlarge` (8 CUs).
        /// </summary>
        [JsonProperty("AppExecutorSize")]
        public string AppExecutorSize{ get; set; }

        /// <summary>
        /// Number of Spark job executors
        /// </summary>
        [JsonProperty("AppExecutorNums")]
        public long? AppExecutorNums{ get; set; }

        /// <summary>
        /// This field has been disused. Use the `Datasource` field instead.
        /// </summary>
        [JsonProperty("Eni")]
        public string Eni{ get; set; }

        /// <summary>
        /// The source of the Spark job package. Valid values: `cos` for COS and `lakefs` for the local system (for use in the console, but this method does not support direct API calls).
        /// </summary>
        [JsonProperty("IsLocal")]
        public string IsLocal{ get; set; }

        /// <summary>
        /// The main class of the Spark job.
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// Spark configurations separated by line break
        /// </summary>
        [JsonProperty("AppConf")]
        public string AppConf{ get; set; }

        /// <summary>
        /// The source of the dependency JAR packages of the Spark job. Valid values: `cos` for COS and `lakefs` for the local system (for use in the console, but this method does not support direct API calls).
        /// </summary>
        [JsonProperty("IsLocalJars")]
        public string IsLocalJars{ get; set; }

        /// <summary>
        /// The dependency JAR packages of the Spark JAR job (JAR packages), separated by comma.
        /// </summary>
        [JsonProperty("AppJars")]
        public string AppJars{ get; set; }

        /// <summary>
        /// The source of the dependency files of the Spark job. Valid values: `cos` for COS and `lakefs` for the local system (for use in the console, but this method does not support direct API calls).
        /// </summary>
        [JsonProperty("IsLocalFiles")]
        public string IsLocalFiles{ get; set; }

        /// <summary>
        /// The dependency files of the Spark job (files other than JAR and ZIP packages) separated by comma.
        /// </summary>
        [JsonProperty("AppFiles")]
        public string AppFiles{ get; set; }

        /// <summary>
        /// The input parameters of the Spark job, separated by comma.
        /// </summary>
        [JsonProperty("CmdArgs")]
        public string CmdArgs{ get; set; }

        /// <summary>
        /// The maximum number of retries, valid for Spark streaming tasks only.
        /// </summary>
        [JsonProperty("MaxRetries")]
        public long? MaxRetries{ get; set; }

        /// <summary>
        /// The data source name.
        /// </summary>
        [JsonProperty("DataSource")]
        public string DataSource{ get; set; }

        /// <summary>
        /// The source of the PySpark dependencies. Valid values: `cos` for COS and `lakefs` for the local system (for use in the console, but this method does not support direct API calls).
        /// </summary>
        [JsonProperty("IsLocalPythonFiles")]
        public string IsLocalPythonFiles{ get; set; }

        /// <summary>
        /// The PySpark dependencies (Python files), separated by comma, with .py, .zip, and .egg formats supported.
        /// </summary>
        [JsonProperty("AppPythonFiles")]
        public string AppPythonFiles{ get; set; }

        /// <summary>
        /// The source of the dependency archives of the Spark job. Valid values: `cos` for COS and `lakefs` for the local system (for use in the console, but this method does not support direct API calls).
        /// </summary>
        [JsonProperty("IsLocalArchives")]
        public string IsLocalArchives{ get; set; }

        /// <summary>
        /// The dependency archives of the Spark job, separated by comma, with tar.gz, .tgz, and .tar formats supported.
        /// </summary>
        [JsonProperty("AppArchives")]
        public string AppArchives{ get; set; }

        /// <summary>
        /// The Spark image version.
        /// </summary>
        [JsonProperty("SparkImage")]
        public string SparkImage{ get; set; }

        /// <summary>
        /// The Spark image version name.
        /// </summary>
        [JsonProperty("SparkImageVersion")]
        public string SparkImageVersion{ get; set; }

        /// <summary>
        /// The specified executor count (max), which defaults to 1. This parameter applies if the "Dynamic" mode is selected. If the "Dynamic" mode is not selected, the executor count is equal to `AppExecutorNums`.
        /// </summary>
        [JsonProperty("AppExecutorMaxNumbers")]
        public long? AppExecutorMaxNumbers{ get; set; }

        /// <summary>
        /// The ID of the associated Data Lake Compute query script.
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// Whether to inherit the task resource configuration from the cluster template. Valid values: `0` (default): No; `1`: Yes.
        /// </summary>
        [JsonProperty("IsInherit")]
        public ulong? IsInherit{ get; set; }

        /// <summary>
        /// Whether to run the task with the session SQLs. Valid values: `false` for no and `true` for yes.
        /// </summary>
        [JsonProperty("IsSessionStarted")]
        public bool? IsSessionStarted{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "DataEngine", this.DataEngine);
            this.SetParamSimple(map, prefix + "AppFile", this.AppFile);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "AppDriverSize", this.AppDriverSize);
            this.SetParamSimple(map, prefix + "AppExecutorSize", this.AppExecutorSize);
            this.SetParamSimple(map, prefix + "AppExecutorNums", this.AppExecutorNums);
            this.SetParamSimple(map, prefix + "Eni", this.Eni);
            this.SetParamSimple(map, prefix + "IsLocal", this.IsLocal);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "AppConf", this.AppConf);
            this.SetParamSimple(map, prefix + "IsLocalJars", this.IsLocalJars);
            this.SetParamSimple(map, prefix + "AppJars", this.AppJars);
            this.SetParamSimple(map, prefix + "IsLocalFiles", this.IsLocalFiles);
            this.SetParamSimple(map, prefix + "AppFiles", this.AppFiles);
            this.SetParamSimple(map, prefix + "CmdArgs", this.CmdArgs);
            this.SetParamSimple(map, prefix + "MaxRetries", this.MaxRetries);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "IsLocalPythonFiles", this.IsLocalPythonFiles);
            this.SetParamSimple(map, prefix + "AppPythonFiles", this.AppPythonFiles);
            this.SetParamSimple(map, prefix + "IsLocalArchives", this.IsLocalArchives);
            this.SetParamSimple(map, prefix + "AppArchives", this.AppArchives);
            this.SetParamSimple(map, prefix + "SparkImage", this.SparkImage);
            this.SetParamSimple(map, prefix + "SparkImageVersion", this.SparkImageVersion);
            this.SetParamSimple(map, prefix + "AppExecutorMaxNumbers", this.AppExecutorMaxNumbers);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "IsInherit", this.IsInherit);
            this.SetParamSimple(map, prefix + "IsSessionStarted", this.IsSessionStarted);
        }
    }
}


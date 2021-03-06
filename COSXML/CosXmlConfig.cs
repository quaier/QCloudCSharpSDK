﻿using System;
using System.Collections.Generic;

using System.Text;
using COSXML.Network;
/**
* Copyright (c) 2018 Tencent Cloud. All rights reserved.
* 11/6/2018 9:29:29 PM
* bradyxiao
*/
namespace COSXML
{
    public sealed class CosXmlConfig
    {
        private HttpClientConfig httpConfig;
        private string appid;
        private string region;
        private bool isHttps;
        private bool isDebug;

        private CosXmlConfig(Builder builder)
        {
            this.appid = builder.appid;
            this.region = builder.region;
            this.isHttps = builder.isHttps;
            this.httpConfig = builder.httpClientConfigBuilder.Build();
            this.isDebug = builder.isDebug;
        }

        public string Appid
        {
            get { return appid; }
            private set { }
        }

        public string Region
        {
            get { return region; }
            private set { }
        }

        public bool IsHttps
        {
            get { return isHttps; }
            private set { }
        }

        public HttpClientConfig HttpConfig
        {
            get { return httpConfig; }
            private set { }
        }

        public bool IsDebugLog
        {
            get { return isDebug; }
            private set { }
        }

        public sealed class Builder
        {
            internal string appid;
            internal string region;
            internal bool isHttps = false;
            internal HttpClientConfig.Builder httpClientConfigBuilder;
            internal bool isDebug = false;
            public Builder() 
            {
                httpClientConfigBuilder = new HttpClientConfig.Builder();
            }
            public Builder SetAppid(string appid)
            {
                this.appid = appid;
                return this;
            }

            public Builder SetRegion(string region)
            {
                this.region = region;
                return this;
            }

            public Builder IsHttps(bool isHttps)
            {
                this.isHttps = isHttps;
                return this;
            }
            public Builder SetConnectionLimit(int connectionLimit)
            {
                this.httpClientConfigBuilder.SetConnectionLimit(connectionLimit);
                return this;
            }

            public Builder SetMaxRetry(int maxRetry)
            {
                this.httpClientConfigBuilder.SetMaxRetry(maxRetry);
                return this;
            }

            public Builder SetConnectionTimeoutMs(int connectionTimeoutMs)
            {
                this.httpClientConfigBuilder.SetConnectionTimeoutMs(connectionTimeoutMs);
                return this;
            }

            public Builder SetReadWriteTimeoutMs(int readWriteTimeoutMs)
            {
                this.httpClientConfigBuilder.SetReadWriteTimeoutMs(readWriteTimeoutMs);
                return this;
            }

            public Builder SetProxyHost(string host)
            {
                this.httpClientConfigBuilder.SetProxyHost(host);
                return this;
            }

            public Builder SetProxyPort(int port)
            {
                this.httpClientConfigBuilder.SetProxyPort(port);
                return this;
            }

            public Builder SetProxyUserName(string userName)
            {
                this.httpClientConfigBuilder.SetProxyUserName(userName);
                return this;
            }

            public Builder SetProxyUserPassword(string password)
            {
                this.httpClientConfigBuilder.SetProxyUserPassword(password);
                return this;
            }

            public Builder SetProxyDomain(string domain)
            {
                this.httpClientConfigBuilder.SetProxyDomain(domain);
                return this;
            }

            public Builder SetDebugLog(bool isDebug)
            {
                this.isDebug = isDebug;
                return this;
            }

            public CosXmlConfig Build()
            {
                return new CosXmlConfig(this);
            }

        }
    }
}

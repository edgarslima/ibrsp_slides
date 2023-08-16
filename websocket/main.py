import asyncio
import websockets

CLIENTS = set()


async def broadcast(websockets, message):
    for ws in websockets:
        try:
            await ws.send(message)
        except:
            pass


async def handler(websocket):
    CLIENTS.add(websocket)
    while True:
        try:
            message = await websocket.recv()
        except websockets.ConnectionClosedOK:
            break
        try:
            # await websocket.send('mensagem_ok')
            if (message != '|CONECT|'):
                await broadcast(CLIENTS, message)
            # print(message)
        except:
            pass




async def main():
    async with websockets.serve(handler, "", 8001):
        await asyncio.Future()  # run forever


if __name__ == "__main__":
    print("Iniciando servidor de comunicação...")
    asyncio.run(main())